﻿using System;

namespace Doggis.Domain.Entities
{
    public class Fabricante : EntityBase
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }
    }
}
