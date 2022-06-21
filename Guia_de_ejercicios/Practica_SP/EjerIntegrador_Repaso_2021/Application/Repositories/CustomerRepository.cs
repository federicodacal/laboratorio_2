using System;
using System.Collections.Generic;
using System.Linq;
using Application.Exceptions;
using Application.DataAcces;
using Application.Models;
using Application.Common;

namespace Application.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        private static List<Customer> customers;

        #region -- Los datos no se encuentran guardados más que en memoria --

        static CustomerRepository()
        {
            CustomerRepository.customers = new List<Customer>();

            //for (int i = 0; i < 100; i++)
            //{
            //    Customer customer = new Customer();
            //    customer.Id = i + 1;
            //    customer.Name = "CustomerName" + customer.Id;
            //    customer.LastName = "CustomerLastname" + customer.Id;
            //    customer.Age = 20 + (int)customer.Id;
            //    customers.Add(customer);
            //}
        }

        #endregion

        public static List<Customer> Customers
        {
            get { return CustomerRepository.customers; }
        }

        public override void Create(Customer entity)
        {
            try
            {
                long lastId;
                if (customers.Count > 0)
                {
                    lastId = (long)(customers[customers.Count - 1]).Id;
                }
                else
                {
                    lastId = 0;
                }
                entity.Id = lastId + 1;
                if (customers != entity)
                {
                    customers.Add(entity);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                throw new TechnicalException(
                    string.Format("No se pudo crear el cliente \"{0} {1}\".", entity.Name, entity.LastName),
                    ex);
            }

        }

        public override List<Customer> GetAll()
        {
            // Devuelve una nueva lista ordenada

            CustomerRepository.customers.Sort(OrdenarPorId);          
            return customers.ToList();
        }

        public static int OrdenarPorId(Customer c1, Customer c2)
        {
            return (int)(c1.Id - c2.Id);
        } 

        public List<Customer> GetAll(string path)
        {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            customers.AddRange(customerSerializer.Read(path));
            return customers;
        }

        public override Customer GetById(long entityId)
        {
            Customer c = null;
            if(!(CustomerRepository.customers is null))
            {
                foreach (Customer item in CustomerRepository.customers)
                {
                    if(item.Id == entityId)
                    {
                        c = item;
                        break;
                    }
                }
            }
            return c;
        }

        public override void Remove(Customer entity)
        {
            if (!(CustomerRepository.customers is null && entity is null))
            {
                for (int i = 0; i < CustomerRepository.customers.Count; i++)
                {
                    if(CustomerRepository.customers[i] == entity)
                    {
                        CustomerRepository.customers.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        public override void Update(Customer entity)
        {
            if(!(entity is null))
            {
                Customer updated = this.GetById(entity.Id);
                updated.Name = entity.Name;
                updated.LastName = entity.LastName;
                updated.Age = entity.Age;
            }
        }

        public List<Customer> LoadFromFile(string path)
        {

            CustomerSerializer customerSerializer = new CustomerSerializer();
            customers.AddRange(customerSerializer.Read(path));
            return customers;
        }

        public bool SaveToFile(List<Customer> customers)
        {
            CustomerSerializer customerSerializer = new CustomerSerializer();
            return customerSerializer.Save(customers);
        }

    }
}
