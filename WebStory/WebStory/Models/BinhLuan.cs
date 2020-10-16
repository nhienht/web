namespace WebStory.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="BinhLuan" />.
    /// </summary>
    public class BinhLuan
    {
        /// <summary>
        /// Defines the idBinhLuan.
        /// </summary>
        private int idBinhLuan;

        /// <summary>
        /// Defines the idTruyen.
        /// </summary>
        private int idTruyen;

        /// <summary>
        /// Defines the noiDung.
        /// </summary>
        private String noiDung;

        /// <summary>
        /// Defines the idnguoidung.
        /// </summary>
        private int idnguoidung;

        /// <summary>
        /// Defines the trangthai.
        /// </summary>
        private int trangthaiBL;

        /// <summary>
        /// Defines the ngayBinhLuan.
        /// </summary>
        private DateTime ngayBinhLuan;

        /// <summary>
        /// Initializes a new instance of the <see cref="BinhLuan"/> class.
        /// </summary>
        public BinhLuan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinhLuan"/> class.
        /// </summary>
        /// <param name="idBinhLuan">The idBinhLuan<see cref="int"/>.</param>
        /// <param name="idTruyen">The idTruyen<see cref="int"/>.</param>
        /// <param name="noiDung">The noiDung<see cref="String"/>.</param>
        /// <param name="idnguoidung">The idnguoidung<see cref="int"/>.</param>
        /// <param name="trangthai">The trangthai<see cref="int"/>.</param>
        /// <param name="ngayBinhLuan">The ngayBinhLuan<see cref="DateTime"/>.</param>
        public BinhLuan(int idBinhLuan, int idTruyen, String noiDung, int idnguoidung, int trangthaiBL, DateTime ngayBinhLuan)
        {
            this.idBinhLuan = idBinhLuan;
            this.idTruyen = idTruyen;
            this.noiDung = noiDung;
            this.idnguoidung = idnguoidung;
            this.trangthaiBL = trangthaiBL;
            this.ngayBinhLuan = ngayBinhLuan;
        }

        /// <summary>
        /// The getIdBinhLuan.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdBinhLuan()
        {
            return idBinhLuan;
        }

        /// <summary>
        /// The setIdBinhLuan.
        /// </summary>
        /// <param name="idBinhLuan">The idBinhLuan<see cref="int"/>.</param>
        public void setIdBinhLuan(int idBinhLuan)
        {
            this.idBinhLuan = idBinhLuan;
        }

        /// <summary>
        /// The getIdTruyen.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdTruyen()
        {
            return idTruyen;
        }

        /// <summary>
        /// The setIdTruyen.
        /// </summary>
        /// <param name="idTruyen">The idTruyen<see cref="int"/>.</param>
        public void setIdTruyen(int idTruyen)
        {
            this.idTruyen = idTruyen;
        }

        /// <summary>
        /// The getNoiDung.
        /// </summary>
        /// <returns>The <see cref="String"/>.</returns>
        public String getNoiDung()
        {
            return noiDung;
        }

        /// <summary>
        /// The setNoiDung.
        /// </summary>
        /// <param name="noiDung">The noiDung<see cref="String"/>.</param>
        public void setNoiDung(String noiDung)
        {
            this.noiDung = noiDung;
        }

        /// <summary>
        /// The getIdnguoidung.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdnguoidung()
        {
            return idnguoidung;
        }

        /// <summary>
        /// The setIdnguoidung.
        /// </summary>
        /// <param name="idnguoidung">The idnguoidung<see cref="int"/>.</param>
        public void setIdnguoidung(int idnguoidung)
        {
            this.idnguoidung = idnguoidung;
        }

        /// <summary>
        /// The getTrangthai.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getTrangthai()
        {
            return trangthaiBL;
        }

        /// <summary>
        /// The setTrangthai.
        /// </summary>
        /// <param name="trangthai">The trangthai<see cref="int"/>.</param>
        public void setTrangthai(int trangthaiBL)
        {
            this.trangthaiBL = trangthaiBL;
        }

        /// <summary>
        /// The getNgayBinhLuan.
        /// </summary>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public DateTime getNgayBinhLuan()
        {
            return ngayBinhLuan;
        }

        /// <summary>
        /// The setNgayBinhLuan.
        /// </summary>
        /// <param name="ngayBinhLuan">The ngayBinhLuan<see cref="DateTime"/>.</param>
        public void setNgayBinhLuan(DateTime ngayBinhLuan)
        {
            this.ngayBinhLuan = ngayBinhLuan;
        }
    }
}
