﻿using CyberSharp.Helpers;

namespace CyberSharp
{
    public abstract class AbstractPerson
    {
        public string Name { get; init; } = Generator.GetRandomName();
        public string IpAdress { get; init; } = Generator.GetRandomIp();
        public BitcoinVallet BtcVallet { get; init; }
        public int HackCounter { get; set; } = 0;
        public int CurrentSuccess { get; set; } = 0;

        public override string ToString() => $"Name: {Name}, IP: {IpAdress}";

        public abstract int CalculateDefence();
    }
}
