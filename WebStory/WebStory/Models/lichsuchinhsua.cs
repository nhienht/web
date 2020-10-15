using System;

namespace WebStory.Models
{
    public class lichsuchinhsua
    {
        public lichsuchinhsua() { }

        private int idLichSu;//store id for lich su chinh sua
        private int idTruyen;//store id for truyen
        private DateTime ngaychinhsua;//store date for ngay chinh sua

        /**
         * Create constructor for class lich su chinh sua
         *
         * @param idLichSu
         * @param idTruyen
         * @param ngaychinhsua
         */
        public lichsuchinhsua(int idLichSu, int idTruyen, DateTime ngaychinhsua)
        {
            this.idLichSu = idLichSu;
            this.idTruyen = idTruyen;
            this.ngaychinhsua = ngaychinhsua;
        }

        /**
         * gets idLichSu for lich su chinh sua
         *
         * @return
         */
        public int getIdLichSu()
        {
            return idLichSu;
        }

        /**
         * sets idLichSu for lich su chinh sua
         *
         * @param idLichSu
         */
        public void setIdLichSu(int idLichSu)
        {
            this.idLichSu = idLichSu;
        }

        /**
         * gets idTruyen for lich su chinh sua
         *
         * @return
         */
        public int getIdTruyen()
        {
            return idTruyen;
        }

        /**
         * sets idTruyen cua lich su chinh sua
         *
         * @param idTruyen
         */
        public void setIdTruyen(int idTruyen)
        {
            this.idTruyen = idTruyen;
        }

        /**
         * gets Ngaychinhsua for lich su chinh sua
         *
         * @return
         */
        public DateTime getNgaychinhsua()
        {
            return ngaychinhsua;
        }

        /**
         * sets Ngaychinhsua for lich su chinh sua
         *
         * @param ngaychinhsua
         */
        public void setNgaychinhsua(DateTime ngaychinhsua)
        {
            this.ngaychinhsua = ngaychinhsua;
        }
    }
}
