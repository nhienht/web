using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStory.Models
{
    public class Truyen
    {
        public int idTruyen { get; set; }
        public String tenTruyen { get; set; }
        public String tomTat { get; set; }
        public DateTime ngayTao { get; set; }
        public String poster { get; set; }
        public String nguon { get; set; }
        public int SLND { get; set; }
        public int idLoai { get; set; }
        public int idQuyen { get; set; }
        public int idTTTHT { get; set; }
        public int idND { get; set; }
        public int trangthaiTruyen { get; set; }
        public Truyen()
        {

        }

        public Truyen(int idTruyen, String tenTruyen, String tomTat, DateTime ngayTao, String poster, String nguon, int SLND, int idLoai, int idQuyen, int idTTTHT, int idnguoidung, int trangthaiTruyen)
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
            this.idND = idnguoidung;
            this.trangthaiTruyen = trangthaiTruyen;
        }



    }
}
