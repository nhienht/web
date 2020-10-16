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
        public int idPhanhoi { get; set; }

        /// <summary>
        /// Defines the idnguoidung.
        /// </summary>
        private int idNguoiDung { get; set; }

        /// <summary>
        /// Defines the tieude.
        /// </summary>
        private String tieude { get; set; }

        /// <summary>
        /// Defines the noiDung.
        /// </summary>
        private String noiDungPH { get; set; }

        /// <summary>
        /// Defines the ngay.
        /// </summary>
        private DateTime ngayPH { get; set; }

        /// <summary>
        /// Defines the trangthai.
        /// </summary>
        private int trangthaiPH { get; set; }

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
        public PhanHoi(int idPhanhoi, int idNguoiDung, String tieude, String noiDungPH, DateTime ngayPH, int trangthaiPH)
        {
            this.idPhanhoi = idPhanhoi;
            this.idNguoiDung = idNguoiDung;
            this.tieude = tieude;
            this.noiDungPH = noiDungPH;
            this.ngayPH = ngayPH;
            this.trangthaiPH = trangthaiPH;
        }

        
    }
}
