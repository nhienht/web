using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStory.Models
{
    public class Truyen
    {
        private int idTruyen;
        private String tenTruyen;
        private String tomTat;
        private DateTime ngayTao;
        private String poster;
        private String nguon;
        private int SLND;
        private int idLoai;
        private int idQuyen;
        private int idTTTHT;
        private int idnguoidung;
        public Truyen()
        {

        }

        public Truyen(int idTruyen, String tenTruyen, String tomTat, DateTime ngayTao, String poster, String nguon, int SLND, int idLoai, int idQuyen, int idTTTHT, int idnguoidung)
        {
            this.idTruyen = idTruyen;
            this.tenTruyen = tenTruyen;
            this.tomTat = tomTat;
            this.ngayTao = ngayTao;
            this.poster = poster;
            this.nguon = nguon;
            this.SLND = SLND;
            this.idLoai = idLoai;
            this.idQuyen = idQuyen;
            this.idTTTHT = idTTTHT;
            this.idnguoidung = idnguoidung;
        }


        public int getIdTruyen()
        {
            return idTruyen;
        }

        public void setIdTruyen(int idTruyen)
        {
            this.idTruyen = idTruyen;
        }

        public String getTenTruyen()
        {
            return tenTruyen;
        }

        public void setTenTruyen(String tenTruyen)
        {
            this.tenTruyen = tenTruyen;
        }

        public String getTomTat()
        {
            return tomTat;
        }

        public void setTomTat(String tomTat)
        {
            this.tomTat = tomTat;
        }

        public DateTime getNgayTao()
        {
            return ngayTao;
        }

        public void setNgayTao(DateTime ngayTao)
        {
            this.ngayTao = ngayTao;
        }

        public String getPoster()
        {
            return poster;
        }

        public void setPoster(String poster)
        {
            this.poster = poster;
        }

        public String getNguon()
        {
            return nguon;
        }

        public void setNguon(String nguon)
        {
            this.nguon = nguon;
        }

        public int getSLND()
        {
            return SLND;
        }

        public void setSLND(int SLND)
        {
            this.SLND = SLND;
        }

        public int getIdLoai()
        {
            return idLoai;
        }

        public void setIdLoai(int idLoai)
        {
            this.idLoai = idLoai;
        }

        public int getIdQuyen()
        {
            return idQuyen;
        }

        public void setIdQuyen(int idQuyen)
        {
            this.idQuyen = idQuyen;
        }

        public int getIdTTTHT()
        {
            return idTTTHT;
        }

        public void setIdTTTHT(int idTTTHT)
        {
            this.idTTTHT = idTTTHT;
        }

        public int getIdnguoidung()
        {
            return idnguoidung;
        }

        public void setIdnguoidung(int idnguoidung)
        {
            this.idnguoidung = idnguoidung;
        }
    }
}
