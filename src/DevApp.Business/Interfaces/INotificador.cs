﻿using DevApp.Business.Notificacoes;
using System.Collections.Generic;

namespace DevApp.Business.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
