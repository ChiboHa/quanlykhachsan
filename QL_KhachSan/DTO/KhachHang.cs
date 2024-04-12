using System;

namespace QL_KhachSan.DTO
{
    internal class KhachHang
    {
        private String id;
        private String name;
        private String phoneNumber;
        private String cccd;


        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Cccd { get => cccd; set => cccd = value; }

        public KhachHang(string id, string name, string phoneNumber, string cccd)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.cccd = cccd;
        }
    }
}
