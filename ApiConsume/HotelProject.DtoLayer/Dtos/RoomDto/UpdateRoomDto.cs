using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen bir oda numarası giriniz")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen bir oda resmi giriniz")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen bir fiyat giriniz")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen bir oda başlığı giriniz")]
        [StringLength(100, ErrorMessage = "Oda başlığı en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı giriniz")]
        public string BathCount { get; set; }
   
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
