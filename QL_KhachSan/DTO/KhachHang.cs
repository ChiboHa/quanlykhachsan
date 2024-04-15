﻿using System;
using System.Data;

namespace QL_KhachSan.DTO
{
    internal class KhachHang
    {
        private String id;
        private String name;
        private String cccd;


        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public KhachHang(DataRow item)
        {
            this.Id = item["ID"].ToString();
            this.Name = item["name"].ToString();
            this.Cccd = item["CCCD"].ToString();  
        }
        public KhachHang(string id, string name, string cccd)
        {
            this.id = id;
            this.name = name;
            this.cccd = cccd;
        }
    }
}
