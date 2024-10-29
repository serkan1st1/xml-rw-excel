using Microsoft.EntityFrameworkCore.Internal;
using System.Security.Cryptography;
using System.Text;
using TaskMvc.Interface;
using TaskMvc.Interface.Repository;
using TaskMvc.Models.Entities;

namespace TaskMvc.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        public async Task RegisterUserAsync(Register model,IFormFile profileImage)
        {

            // Şifreyi hash'le
            var hashedPassword = HashPassword(model.Password);
            string profileImagePath = null;

            if (profileImage != null && profileImage.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var mntUploadsFolder = "/mnt/uploads";
                if (!Directory.Exists(mntUploadsFolder))
                {
                    Directory.CreateDirectory(mntUploadsFolder);
                }

                // Resim dosyasının benzersiz bir adla kaydedilmesi
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + profileImage.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await profileImage.CopyToAsync(stream);
                }

                // /mnt/uploads içine kaydetme
                var mntFilePath = Path.Combine(mntUploadsFolder, uniqueFileName);
                using (var mntStream = new FileStream(mntFilePath, FileMode.Create))
                {
                    await profileImage.CopyToAsync(mntStream);
                }

                // Veritabanında saklayacağımız dosya yolu
                profileImagePath = "/uploads/" + uniqueFileName;
            }

            // Kullanıcı nesnesini oluştur
            var user = new Register
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Password = hashedPassword,
                ProfileImagePath = profileImagePath // Veritabanında saklanacak resim yolu
            };

            // Kullanıcıyı veritabanına ekle
            await _userRepository.AddUserAsync(user);

        }


        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
