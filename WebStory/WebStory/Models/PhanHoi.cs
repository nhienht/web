namespace WebStory.Models
{
    using System;

    /// <summary>
    /// Defines the <see cref="PhanHoi" />.
    /// </summary>
    public class PhanHoi
    {
        /// <summary>
        /// Defines the idPhanhoi.
        /// </summary>
        private int idPhanhoi;

        /// <summary>
        /// Defines the idnguoidung.
        /// </summary>
        private int idnguoidung;

        /// <summary>
        /// Defines the tieude.
        /// </summary>
        private String tieude;

        /// <summary>
        /// Defines the noiDung.
        /// </summary>
        private String noiDung;

        /// <summary>
        /// Defines the ngay.
        /// </summary>
        private DateTime ngay;

        /// <summary>
        /// Defines the trangthai.
        /// </summary>
        private int trangthai;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhanHoi"/> class.
        /// </summary>
        public PhanHoi()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhanHoi"/> class.
        /// </summary>
        /// <param name="idPhanhoi">The idPhanhoi<see cref="int"/>.</param>
        /// <param name="idnguoidung">The idnguoidung<see cref="int"/>.</param>
        /// <param name="tieude">The tieude<see cref="String"/>.</param>
        /// <param name="noiDung">The noiDung<see cref="String"/>.</param>
        /// <param name="ngay">The ngay<see cref="DateTime"/>.</param>
        /// <param name="trangthai">The trangthai<see cref="int"/>.</param>
        public PhanHoi(int idPhanhoi, int idnguoidung, String tieude, String noiDung, DateTime ngay, int trangthai)
        {
            this.idPhanhoi = idPhanhoi;
            this.idnguoidung = idnguoidung;
            this.tieude = tieude;
            this.noiDung = noiDung;
            this.ngay = ngay;
            this.trangthai = trangthai;
        }

        /// <summary>
        /// The getIdPhanhoi.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdPhanhoi()
        {
            return idPhanhoi;
        }

        /// <summary>
        /// The setIdPhanhoi.
        /// </summary>
        /// <param name="idPhanhoi">The idPhanhoi<see cref="int"/>.</param>
        public void setIdPhanhoi(int idPhanhoi)
        {
            this.idPhanhoi = idPhanhoi;
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
        /// The getTieude.
        /// </summary>
        /// <returns>The <see cref="String"/>.</returns>
        public String getTieude()
        {
            return tieude;
        }

        /// <summary>
        /// The setTieude.
        /// </summary>
        /// <param name="tieude">The tieude<see cref="String"/>.</param>
        public void setTieude(String tieude)
        {
            this.tieude = tieude;
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
        /// The getNgay.
        /// </summary>
        /// <returns>The <see cref="DateTime"/>.</returns>
        public DateTime getNgay()
        {
            return ngay;
        }

        /// <summary>
        /// The setNgay.
        /// </summary>
        /// <param name="ngay">The ngay<see cref="DateTime"/>.</param>
        public void setNgay(DateTime ngay)
        {
            this.ngay = ngay;
        }

        /// <summary>
        /// The getTrangthai.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getTrangthai()
        {
            return trangthai;
        }

        /// <summary>
        /// The setTrangthai.
        /// </summary>
        /// <param name="trangthai">The trangthai<see cref="int"/>.</param>
        public void setTrangthai(int trangthai)
        {
            this.trangthai = trangthai;
        }
    }
}
