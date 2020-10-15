using System;
namespace WebStory.Models
{
    public class loai
    {


        private int idLoai;//store  id for loai
        private String tenLoai;//store ten for loai

        /**
         * Create Constructor for class loai
         *
         * @param idLoai
         * @param tenLoai
         */
        public loai(int idLoai, String tenLoai)
        {
            this.idLoai = idLoai;
            this.tenLoai = tenLoai;
        }

        /**
         * gets IdLoai for loai
         *
         * @return
         */
        public int getIdLoai()
        {
            return idLoai;
        }

        /**
         * sets IdLoai for loai
         *
         * @param idLoai
         */
        public void setIdLoai(int idLoai)
        {
            this.idLoai = idLoai;
        }

        /**
         * gets TenLoai for loai
         *
         * @return
         */
        public String getTenLoai()
        {
            return tenLoai;
        }

        /**
         * sets TenLoai for loai
         *
         * @param tenLoai
         */
        public void setTenLoai(String tenLoai)
        {
            this.tenLoai = tenLoai;
        }
    }
}

