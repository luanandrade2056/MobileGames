﻿namespace Web.Models
{
    public class Item
    {
        public int ItemID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int qualidade { get; set; }

        public int DanoBase { get; set; }

        // Relacionamento item -- TipoItem
        public int TipoItemID { get; set; }

        public virtual TipoItem _TipoItem { get; set; }

    }
}