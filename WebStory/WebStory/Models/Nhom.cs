using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStory.Models
{
    public class Nhom
    {
        private int idNhom;
        private int idnguoidung;
        private int quyen;
        private int idTruyen;
        public Nhom()
        {

        }

        public Nhom(int idNhom, int idnguoidung, int quyen, int idTruyen)
        {
            this.idNhom = idNhom;
            this.idnguoidung = idnguoidung;
            this.quyen = quyen;
            this.idTruyen = idTruyen;
        }


        public int getIdNhom()
        {
            return idNhom;
        }

        public void setIdNhom(int idNhom)
        {
            this.idNhom = idNhom;
        }

        public int getIdnguoidung()
        {
            return idnguoidung;
        }

        public void setIdnguoidung(int idnguoidung)
        {
            this.idnguoidung = idnguoidung;
        }

        public int getQuyen()
        {
            return quyen;
        }

        public void setQuyen(int quyen)
        {
            this.quyen = quyen;
        }

        public int getIdTruyen()
        {
            return idTruyen;
        }

        public void setIdTruyen(int idTruyen)
        {
            this.idTruyen = idTruyen;
        }
    }
}
