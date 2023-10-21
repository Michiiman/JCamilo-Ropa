

namespace Dominio.Entities;

    public class Proveedor : BaseEntity
    {
        public int NitProveedor{get;set;}
        public string Nombre{get;set;}
        public int TipoPersonaIdFk{get;set;}
        public TipoPersona TipoPersona{get;set;}
        public int MunicipioIdFk{get;set;}
        public Municipio Municipio{get;set;}

        //Collections
        public ICollection<Insumo> Insumos{get;set;}
        public ICollection<InsumoProveedor> InsumoProveedores{get;set;}

    }
