﻿using System;
using System.Collections.Generic;
using System.Text;

namespace T1806E_CSharp
{
    class SinhVien
    {
        public void name;
        public void age;
        public void mark;

        public void NhapThongTin()
        {
            Console.WriteLine("Nhap ten:");
            name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi:");
            age = Console.Read();
            Console.WriteLine("Nhap diem thi:");
            mark = Console.Read();
        }
        public void InThongTin()
        {
            Console.WriteLine("Ten: " + name);
            Console.WriteLine("Tuoi: " + age);
            Console.WriteLine("Diem thi: " + mark);
        }
        public void BaoKetQua()
        {
            if(mark >=4)
            {
                Console.WriteLine("Qua mon!");
                return;
            }
            Console.WriteLine("Khong qua mon!");
        }
    }
}
