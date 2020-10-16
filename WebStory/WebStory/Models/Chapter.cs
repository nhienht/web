using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStory.Models
{
    public class Chapter
    {
        private int idChap;
        private int idTruyen;
        private int soThuTu;
        private String tieuDe;
        private String noiDung;
        private DateTime ngayDang;
        private int trangthaiCT;
        public Chapter()
        {

        }

        public Chapter(int idChap, int idTruyen, int soThuTu, String tieuDe, String noiDung, DateTime ngayDang, int trangthaiCT)
        {
            this.idChap = idChap;
            this.idTruyen = idTruyen;
            this.soThuTu = soThuTu;
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.ngayDang = ngayDang;
            this.trangthaiCT = trangthaiCT;
        }

        public int getIdChap()
        {
            return idChap;
        }

        public void setIdChap(int idChap)
        {
            this.idChap = idChap;
        }

        public int getIdTruyen()
        {
            return idTruyen;
        }

        public void setIdTruyen(int idTruyen)
        {
            this.idTruyen = idTruyen;
        }

        public int getSoThuTu()
        {
            return soThuTu;
        }

        public void setSoThuTu(int soThuTu)
        {
            this.soThuTu = soThuTu;
        }

        public String getTieuDe()
        {
            return tieuDe;
        }

        public void setTieuDe(String tieuDe)
        {
            this.tieuDe = tieuDe;
        }

        public String getNoiDung()
        {
            return noiDung;
        }

        public void setNoiDung(String noiDung)
        {
            this.noiDung = noiDung;
        }

        public DateTime getNgayDang()
        {
            return ngayDang;
        }

        public void setNgayDang(DateTime ngayDang)
        {
            this.ngayDang = ngayDang;
        }

        public int getTrangthai()
        {
            return trangthaiCT;
        }

        public void setTrangthai(int trangthaiCT)
        {
            this.trangthaiCT = trangthaiCT;
        }
    }
}
