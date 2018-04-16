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
    
    public partial class Musica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musica()
        {
            this.MusicasAlbums = new HashSet<MusicasAlbum>();
            this.MusicasArtistas = new HashSet<MusicasArtista>();
        }
    
        public int idMusica { get; set; }
        public string Nome { get; set; }
        public Nullable<int> Artista { get; set; }
        public Nullable<int> Album { get; set; }
        public Nullable<decimal> Duracao { get; set; }
    
        public virtual Album Album1 { get; set; }
        public virtual Artista Artista1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusicasAlbum> MusicasAlbums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusicasArtista> MusicasArtistas { get; set; }
    }
}
