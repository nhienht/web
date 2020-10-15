using System;
namespace WebStory.Models
{
    public class trangthaithanhtoan
    {
        public trangthaithanhtoan() { }

        private int idTTHT;//store id for trang thai hoan thanh
        private String tenTTHT;//store ten for trang thai hoan thanh

        /**
         * Create constructor for class trang thai hoan thanh
         *
         * @param idTTHT
         * @param tenTTHT
         */
        public trangthaithanhtoan(int idTTHT, String tenTTHT)
        {
            this.idTTHT = idTTHT;
            this.tenTTHT = tenTTHT;
        }

        /**
         * gets idTTHT for trang thai hoan thanh
         *
         * @return
         */
        public int getIdTTHT()
        {
            return idTTHT;
        }

        /**
         * sets idTTHT for trang thai hoan thanh
         *
         * @param idTTHT
         */
        public void setIdTTHT(int idTTHT)
        {
            this.idTTHT = idTTHT;
        }

        /**
         * gets tenTTHT for trang thai hoan thanh
         *
         * @return
         */
        public String getTenTTHT()
        {
            return tenTTHT;
        }

        /**
         * sets tenTTHT for trang thai hoan thanh
         *
         * @param tenTTHT
         */
        public void setTenTTHT(String tenTTHT)
        {
            this.tenTTHT = tenTTHT;
        }

    }
}