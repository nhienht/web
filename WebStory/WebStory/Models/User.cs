namespace WebStory.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Dynamic;

    /// <summary>
    /// Defines the <see cref="User" />.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Defines the idNguoiDung.
        /// </summary>
       
        public int idNguoiDung { get; set; }

        /// <summary>
        /// Defines the tenNguoiDung.
        /// </summary>
        /// 
        [Display(Name = "Nhap ten")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ten khong duoc de trong")]
        public String tenNguoiDung { get; set; }

        /// <summary>
        /// Defines the email.
        /// </summary>
        [Display(Name = "Nhap Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email khong duoc de trong")]
        public String email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage = "Minimum 8 characters required")]
        public String password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password and password do not match")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Defines the ngaysinh.
        /// </summary>
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ngaysinh { get; set; }

        /// <summary>
        /// Defines the gioitinh.
        /// </summary>
        public int gioitinh { get; set; }

        /// <summary>
        /// Defines the trangThai.
        /// </summary>
        public int trangThai { get; set; }

        /// <summary>
        /// Defines the quyen.
        /// </summary>
        public int quyen { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="idNguoiDung">The idNguoiDung<see cref="int"/>.</param>
        /// <param name="tenNguoiDung">The tenNguoiDung<see cref="String"/>.</param>
        /// <param name="email">The email<see cref="String"/>.</param>
        /// <param name="ngaysinh">The ngaysinh<see cref="DateTime"/>.</param>
        /// <param name="gioitinh">The gioitinh<see cref="int"/>.</param>
        /// <param name="trangThai">The trangThai<see cref="int"/>.</param>
        /// <param name="quyen">The quyen<see cref="int"/>.</param>
        public User(int idNguoiDung, String tenNguoiDung, String email, DateTime ngaysinh, int gioitinh, int trangThai, int quyen)
        {
            this.idNguoiDung = idNguoiDung;
            this.tenNguoiDung = tenNguoiDung;
            this.email = email;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.trangThai = trangThai;
            this.quyen = quyen;
        }

        
    }
}
