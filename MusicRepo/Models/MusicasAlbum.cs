//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicRepo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusicasAlbum
    {
        public int idMusicasAlbum { get; set; }
        public int idMusica { get; set; }
        public int idAlbum { get; set; }
    
        public virtual Album Album { get; set; }
        public virtual Musica Musica { get; set; }
    }
}