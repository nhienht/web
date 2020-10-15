using System;
namespace WebStory.Models
{
    public class quyen
    {
        public quyen() { }

        private int idQuyen;//store id for quyen
        private String tenQuyen;//store ten for quyen

        /**
         * Create constructor for quyen
         *
         * @param idQuyen
         * @param tenQuyen
         */
        public quyen(int idQuyen, String tenQuyen)
        {
            this.idQuyen = idQuyen;
            this.tenQuyen = tenQuyen;
        }

        /**
         * gets idQuyen for quyen
         *
         * @return
         */
        public int getIdQuyen()
        {
            return idQuyen;
        }

        /**
         * sets idQuyen for quyen
         *
         * @param idQuyen
         */
        public void setIdQuyen(int idQuyen)
        {
            this.idQuyen = idQuyen;
        }

        /**
         * gets TenQuyen for quyen
         *
         * @return
         */
        public String getTenQuyen()
        {
            return tenQuyen;
        }

        /**
         * sets TenQuyen for quyen
         *
         * @param tenQuyen
         */
        public void setTenQuyen(String tenQuyen)
        {
            this.tenQuyen = tenQuyen;
        }

    }
}
