﻿using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
   public interface IModalitePaiementRepository
    {
        List<ModalitePaiement> GetAll();
        ModalitePaiement GetById(int id);
        Client GetByClient(int id);
        ModalitePaiement Add(ModalitePaiement mlt);
        ModalitePaiement Update(ModalitePaiement mlt);
        bool Delete(int id);
    }
}

