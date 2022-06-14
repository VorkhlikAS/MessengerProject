﻿using System.ComponentModel.DataAnnotations;

namespace MessengerNetSix.Models
{
    public class ChatList
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public bool IsAGroup { get; set; }
    }
}
