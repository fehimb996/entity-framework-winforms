﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Mapper
    {
        #region Classes
        public static EmployeeDTO MapToDTO(Employee e) //Metod MapToDTO uzima entitet Employee i pretvara ga u EmployeeDTO. Popunjava svojstva EmployeeDTO objektima iz Employee entiteta.
        {
            EmployeeDTO emp = new EmployeeDTO();
            emp.EmployeeID = e.EmployeeID;
            emp.LastName = e.LastName;
            emp.FirstName = e.FirstName;
            emp.Title = e.Title;
            emp.TitleOfCourtesy = e.TitleOfCourtesy;
            emp.BirthDate = e.BirthDate;
            emp.HireDate = e.HireDate;
            emp.Address = e.Address;
            emp.City = e.City;
            emp.Region = e.Region;
            emp.PostalCode = e.PostalCode;
            emp.Country = e.Country;
            emp.HomePhone = e.HomePhone;
            emp.Extension = e.Extension;
            emp.Notes = e.Notes;
            emp.ReportsTo = e.ReportsTo;
            emp.PhotoPath = e.PhotoPath;

            return emp;
        }

        public static Employee MapToEntity(EmployeeDTO e) //Metod MapToEntity radi suprotno. Uzima EmployeeDTO i pretvara ga u Employee entitet. Popunjava svojstva Employee objektima iz EmployeeDTO.
        {
            Employee emp = new Employee();

            emp.LastName = e.LastName;
            emp.FirstName = e.FirstName;
            emp.Title = e.Title;
            emp.TitleOfCourtesy = e.TitleOfCourtesy;
            emp.BirthDate = e.BirthDate;
            emp.HireDate = e.HireDate;
            emp.Address = e.Address;
            emp.City = e.City;
            emp.Region = e.Region;
            emp.PostalCode = e.PostalCode;
            emp.Country = e.Country;
            emp.HomePhone = e.HomePhone;
            emp.Extension = e.Extension;
            emp.Photo = null;
            emp.Notes = e.Notes;
            emp.ReportsTo = e.ReportsTo;
            emp.PhotoPath = e.PhotoPath;

            return emp;
        }

        public static Order MapToEntity(OrderDTO oDTP)
        {
            Order o = new Order();

            o.OrderID = oDTP.OrderID;
            o.CustomerID = oDTP.CustomerID;
            o.EmployeeID = oDTP.EmployeeID;
            o.OrderDate = oDTP.OrderDate;
            o.RequiredDate = oDTP.RequiredDate;
            o.ShippedDate = oDTP.ShippedDate;
            o.ShipVia = oDTP.ShipVia;
            o.Freight = oDTP.Freight;
            o.ShipName = oDTP.ShipName;
            o.ShipAddress = oDTP.ShipAddress;
            o.ShipCity = oDTP.ShipCity;
            o.ShipRegion = oDTP.ShipRegion;
            o.ShipPostalCode = oDTP.ShipPostalCode;
            o.ShipCountry = oDTP.ShipCountry;

            return o;
        }

        public static OrderDetailsDTO MapToDTO(Order_Detail o)
        {
            OrderDetailsDTO od = new OrderDetailsDTO();

            od.OrderID = o.OrderID;
            od.ProductID = o.ProductID;
            od.UnitPrice = o.UnitPrice;
            od.Quantity = o.Quantity;
            od.Discount = o.Discount;

            return od;
        }

        public static Order_Detail MapToEntity(OrderDetailsDTO oDTP)
        {
            Order_Detail od = new Order_Detail();

            od.OrderID = oDTP.OrderID;
            od.ProductID = oDTP.ProductID;
            od.UnitPrice = oDTP.UnitPrice;
            od.Quantity = oDTP.Quantity;
            od.Discount = oDTP.Discount;

            return od;
        }

        public static ShipperDTO MapToDTO(Shipper s)
        {
            ShipperDTO sDTO = new ShipperDTO();
            sDTO.ShipperID = s.ShipperID;
            sDTO.CompanyName = s.CompanyName;
            sDTO.Phone = s.Phone;
            return sDTO;
        }

        public static CustomerDTO MapToDTO(Customer c)
        {
            CustomerDTO cDTP = new CustomerDTO();
            cDTP.CustomerID = c.CustomerID;
            cDTP.CompanyName = c.CompanyName;
            cDTP.ContactName = c.ContactName;
            cDTP.ContactTitle = c.ContactTitle;
            cDTP.Address = c.Address;
            cDTP.City = c.City;
            cDTP.Region = c.Region;
            cDTP.PostalCode = c.PostalCode;
            cDTP.Country = c.Country;
            cDTP.Phone = c.Phone;
            cDTP.Fax = c.Fax;

            return cDTP;
        }

        public static ProductDTO MapToDTO(Product p)
        {
            ProductDTO pDTP = new ProductDTO();
            pDTP.ProductID = p.ProductID;
            pDTP.ProductName = p.ProductName;
            pDTP.QuantityPerUnit = p.QuantityPerUnit;
            pDTP.UnitPrice = p.UnitPrice;
            pDTP.UnitsInStock = p.UnitsInStock;
            pDTP.UnitsOnOrder = p.UnitsOnOrder;
            pDTP.ReorderLevel = p.ReorderLevel;
            pDTP.Discontinued = p.Discontinued;

            return pDTP;
        }

        public static OrderDTO MapToDTO(Order o)
        {
            OrderDTO oDTP = new OrderDTO();
            oDTP.OrderID = o.OrderID;
            oDTP.CustomerID = o.CustomerID;
            oDTP.EmployeeID = o.EmployeeID;
            oDTP.OrderDate = o.OrderDate;
            oDTP.RequiredDate = o.RequiredDate;
            oDTP.ShippedDate = o.ShippedDate;
            oDTP.ShipVia = o.ShipVia;
            oDTP.Freight = o.Freight;
            oDTP.ShipName = o.ShipName;
            oDTP.ShipAddress = o.ShipAddress;
            oDTP.ShipCity = o.ShipCity;
            oDTP.ShipRegion = o.ShipRegion;
            oDTP.ShipPostalCode = o.ShipPostalCode;
            oDTP.ShipCountry = o.ShipCountry;

            return oDTP;
        }

        public static OrderDTO MapToDTO(spSearchOrders3_Result result)
        {
            OrderDTO orderDTO = new OrderDTO();
            orderDTO.OrderID = result.OrderID;
            orderDTO.CustomerID = result.CustomerID;
            orderDTO.EmployeeID = result.EmployeeID;
            orderDTO.OrderDate = result.OrderDate;
            orderDTO.RequiredDate = result.RequiredDate;
            orderDTO.ShippedDate = result.ShippedDate;
            orderDTO.ShipVia = result.ShipVia;
            orderDTO.Freight = result.Freight;
            orderDTO.ShipName = result.ShipName;
            orderDTO.ShipAddress = result.ShipAddress;
            orderDTO.ShipCity = result.ShipCity;
            orderDTO.ShipRegion = result.ShipRegion;
            orderDTO.ShipPostalCode = result.ShipPostalCode;
            orderDTO.ShipCountry = result.ShipCountry;

            return orderDTO;
        }

        #endregion

        #region Lists
        //Metod ConvertToList uzima listu Employee entiteta i pretvara je u listu EmployeeDTO objekata. Koristi LINQ Select metod za mapiranje svakog Employee entiteta u EmployeeDTO.
        public static List<EmployeeDTO> convertToList(List<Employee> eList) 
        {
            List<EmployeeDTO> l = new List<EmployeeDTO>();
            foreach (Employee e in eList)
                l.Add(MapToDTO(e));

            return l;
        }

        public static List<OrderDTO> convertToList(List<spSearchOrders3_Result> results)
        {
            List<OrderDTO> orderDTOs = new List<OrderDTO>();
            foreach (var result in results)
            {
                orderDTOs.Add(MapToDTO(result));
            }
            return orderDTOs;
        }

        public static List<OrderDTO> convertToList(List<Order> oList)
        {
            List<OrderDTO> l = new List<OrderDTO>();

            foreach (Order o in oList)
            {
                l.Add(MapToDTO((o)));
            }

            return l;
        }

        public static List<OrderDetailsDTO> convertToList(List<Order_Detail> oList)
        {
            List<OrderDetailsDTO> l = new List<OrderDetailsDTO>();
            foreach (Order_Detail o in oList)
                l.Add(MapToDTO(o));

            return l;
        }

        public static List<ShipperDTO> convertToList(List<Shipper> eList)
        {
            List<ShipperDTO> l = new List<ShipperDTO>();
            foreach (Shipper e in eList)
                l.Add(MapToDTO(e));

            return l;
        }

        public static List<CustomerDTO> convertToList(List<Customer> eList)
        {
            List<CustomerDTO> l = new List<CustomerDTO>();
            foreach (Customer e in eList)
                l.Add(MapToDTO(e));

            return l;
        }

        public static List<ProductDTO> convertToList(List<Product> eList)
        {
            List<ProductDTO> l = new List<ProductDTO>();
            foreach (Product e in eList)
                l.Add(MapToDTO(e));

            return l;
        }


        #endregion
    }
}