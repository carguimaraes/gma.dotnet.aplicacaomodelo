﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMA.AplicacaoModelo.Dominio.Repositorios
{
 public interface IUnitOfWork : IDisposable
 {

  T Repositorio<T>() where T : IRepositorio;

  void BeginTransaction();
  void CommitTransaction();
  void RollBackTransaction();

 }
}
