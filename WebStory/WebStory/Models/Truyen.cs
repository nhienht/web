using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStory.Models
{
    public class Truyen
    {
        private int idTruyen { get; set; }
        private String tenTruyen { get; set; }
        private String tomTat { get; set; }
        private DateTime ngayTao { get; set; }
        private String poster { get; set; }
        private String nguon { get; set; }
        private int SLND { get; set; }
        private int idLoai { get; set; }
        private int idQuyen { get; set; }
        private int idTTTHT { get; set; }
        private int idND { get; set; }
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
            this.idND = idnguoidung;
        }



    }
}
