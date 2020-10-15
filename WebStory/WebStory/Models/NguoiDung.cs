namespace WebStory.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="NguoiDung" />.
    /// </summary>
    public class NguoiDung
    {
        /// <summary>
        /// Defines the idNguoiDung.
        /// </summary>
        private int idNguoiDung;

        /// <summary>
        /// Defines the tenNguoiDung.
        /// </summary>
        private String tenNguoiDung;

        /// <summary>
        /// Defines the email.
        /// </summary>
        private String email;

        /// <summary>
        /// Defines the ngaysinh.
        /// </summary>
        private DateTime ngaysinh;

        /// <summary>
        /// Defines the gioitinh.
        /// </summary>
        private int gioitinh;

        /// <summary>
        /// Defines the trangThai.
        /// </summary>
        private int trangThai;

        /// <summary>
        /// Defines the quyen.
        /// </summary>
        private int quyen;

        /// <summary>
        /// Initializes a new instance of the <see cref="NguoiDung"/> class.
        /// </summary>
        public NguoiDung()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NguoiDung"/> class.
        /// </summary>
        /// <param name="idNguoiDung">The idNguoiDung<see cref="int"/>.</param>
        /// <param name="tenNguoiDung">The tenNguoiDung<see cref="String"/>.</param>
        /// <param name="email">The email<see cref="String"/>.</param>
        /// <param name="ngaysinh">The ngaysinh<see cref="DateTime"/>.</param>
        /// <param name="gioitinh">The gioitinh<see cref="int"/>.</param>
        /// <param name="trangThai">The trangThai<see cref="int"/>.</param>
        /// <param name="quyen">The quyen<see cref="int"/>.</param>
        public NguoiDung(int idNguoiDung, String tenNguoiDung, String email, DateTime ngaysinh, int gioitinh, int trangThai, int quyen)
        {
            this.idNguoiDung = idNguoiDung;
            this.tenNguoiDung = tenNguoiDung;
            this.email = email;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.trangThai = trangThai;
            this.quyen = quyen;
        }

        /// <summary>
        /// The getIdNguoiDung.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdNguoiDung()
        {
            return idNguoiDung;
        }

        /// <summary>
        /// The setIdNguoiDung.
        /// </summary>
        /// <param name="idNguoiDung">The idNguoiDung<see cref="int"/>.</param>
        public void setIdNguoiDung(int idNguoiDung)
        {
            this.idNguoiDung = idNguoiDung;
        }

        /// <summary>
        /// The getTenNguoiDung.
        /// </summary>
        /// <returns>The <see cref="String"/>.</returns>
        public String getTenNguoiDung()
        {
            return tenNguoiDung;
        }

        /// <summary>
        /// The setTenNguoiDung.
        /// </summary>
        /// <param name="tenNguoiDung">The tenNguoiDung<see cref="String"/>.</param>
        public void setTenNguoiDung(String tenNguoiDung)
        {
            this.tenNguoiDung = tenNguoiDung;
        }

        /// <summary>
        /// The getEmail.
        /// </summary>
        /// <returns>The <see cref="String"/>.</returns>
        public String getEmail()
        {
            return email;
        }

        /// <summary>
        /// The setEmail.
        /// </summary>
        /// <param name="email">The email<see cref="String"/>.</param>
        public void setEmail(String email)
        {
            this.email = email;
        }

        /// <summary>
        /// The getNgaysinh.
        /// </summary>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public DateTime getNgaysinh()
        {
            return ngaysinh;
        }

        /// <summary>
        /// The setNgaysinh.
        /// </summary>
        /// <param name="ngaysinh">The ngaysinh<see cref="DateTime"/>.</param>
        public void setNgaysinh(DateTime ngaysinh)
        {
            this.ngaysinh = ngaysinh;
        }

        /// <summary>
        /// The getGioitinh.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getGioitinh()
        {
            return gioitinh;
        }

        /// <summary>
        /// The setGioitinh.
        /// </summary>
        /// <param name="gioitinh">The gioitinh<see cref="int"/>.</param>
        public void setGioitinh(int gioitinh)
        {
            this.gioitinh = gioitinh;
        }

        /// <summary>
        /// The getTrangThai.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getTrangThai()
        {
            return trangThai;
        }

        /// <summary>
        /// The setTrangThai.
        /// </summary>
        /// <param name="trangThai">The trangThai<see cref="int"/>.</param>
        public void setTrangThai(int trangThai)
        {
            this.trangThai = trangThai;
        }

        /// <summary>
        /// The getQuyen.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getQuyen()
        {
            return quyen;
        }

        /// <summary>
        /// The setQuyen.
        /// </summary>
        /// <param name="quyen">The quyen<see cref="int"/>.</param>
        public void setQuyen(int quyen)
        {
            this.quyen = quyen;
        }
    }
}
