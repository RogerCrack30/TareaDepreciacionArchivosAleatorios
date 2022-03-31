using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryEmpleadoRepository: IEmpleadoModel
    {

        private RAFContext<Activo> context;
        private const int SIZE = 568;
        public void Add(Empleado t)
        {
            try
            {
                context.Create<Empleado>(t);
            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Delete(Empleado t)
        {
            try
            {
                context.Delete<Empleado>(t);
            }
            catch (IOException)
            {
                throw;
            }
        }

        public List<Empleado> Find()
        {
            throw new NotImplementedException();
        }

        public Empleado GetById(int id)
        {
            try
            {
                return context.Get<Empleado>(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Empleado> Read()
        {
            try
            {
                return context.GetAll<Empleado>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(Empleado t)
        {
            return context.Update<Empleado>(t);
        }



    }
}
