using System;
namespace WebStory.Models
{
    public class truyenyeuthich
    {
        public truyenyeuthich() { }

        private int idTruyenYeuThich;//store id for truyen yeu thich
        private int idNguoiDung;//store id for nguoi dung
        private int idTruyen;//stote id for truyen

        /**
         * Create constructor for class truyen yeu thich
         *
         * @param idTruyenYeuThich
         * @param idNguoidung
         * @param idTruyen
         */
        public truyenyeuthich(int idTruyenYeuThich, int idNguoidung, int idTruyen)
        {
            this.idTruyenYeuThich = idTruyenYeuThich;
            this.idNguoiDung = idNguoidung;
            this.idTruyen = idTruyen;
        }

        /**
         * gets idTruyenYeuThich for truyen yeu thich
         *
         * @return
         */
        public int getIdTruyenYeuThich()
        {
            return idTruyenYeuThich;
        }

        /**
         * sets idTruyenYeuThich for truyen yeu thich
         *
         * @param idTruyenYeuThich
         */
        public void setIdTruyenYeuThich(int idTruyenYeuThich)
        {
            this.idTruyenYeuThich = idTruyenYeuThich;
        }

        /**
         * gets idNguoidung for nguoi dung
         *
         * @return
         */
        public int getIdNguoidung()
        {
            return idNguoiDung;
        }

        /**
         * sets idNguoidung for nguoi dung
         *
         * @param idNguoidung
         */
        public void setIdNguoidung(int idNguoidung)
        {
            this.idNguoiDung = idNguoidung;
        }

        /**
         * gets idTruyen for truyen
         *
         * @return
         */
        public int getIdTruyen()
        {
            
            return idTruyen;
        }

        /**
         * sets idTruyen for truyen
         *
         * @param idTruyen
         */
        public void setIdTruyen(int idTruyen)
        {
            this.idTruyen = idTruyen;
        }

    }
}