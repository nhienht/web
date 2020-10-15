using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStory.Models
{
    public class Rating
    {
        private int idRating;
        private int idTruyen;
        private int giaTri;
        private DateTime ngayDanhGia;
        public Rating()
        {

        }

        public Rating(int idRating, int idTruyen, int giaTri, DateTime ngayDanhGia)
        {
            this.idRating = idRating;
            this.idTruyen = idTruyen;
            this.giaTri = giaTri;
            this.ngayDanhGia = ngayDanhGia;
        }

        public int getIdRating()
        {
            return idRating;
        }

        public void setIdRating(int idRating)
        {
            this.idRating = idRating;
        }

        public int getIdTruyen()
        {
            return idTruyen;
        }

        public void setIdTruyen(int idTruyen)
        {
            this.idTruyen = idTruyen;
        }

        public int getGiaTri()
        {
            return giaTri;
        }

        public void setGiaTri(int giaTri)
        {
            this.giaTri = giaTri;
        }

        public DateTime getNgayDanhGia()
        {
            return ngayDanhGia;
        }

        public void setNgayDanhGia(DateTime ngayDanhGia)
        {
            this.ngayDanhGia = ngayDanhGia;
        }
    }
}
