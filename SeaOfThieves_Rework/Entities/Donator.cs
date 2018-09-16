﻿using DSharpPlus.Entities;

namespace SeaOfThieves.Entities
{
    public class Donator
    {
        public ulong Member { get; }
        public double Balance { get; private set; }
        public ulong ColorRole { get; private set; }

        public Donator(ulong member, ulong colorRole, double balance = 0)
        {
            Member = member;
            Balance = balance;
            ColorRole = colorRole;

            DonatorList.Donators[Member] = this;
        }

        public void SetBalance(double newBalance)
        {
            Balance = newBalance;
            
            DonatorList.Donators[Member] = this;
        }

        public void SetRole(ulong colorRole)
        {
            ColorRole = colorRole;
            
            DonatorList.Donators[Member] = this;
        }

        public void Remove()
        {
            DonatorList.Donators.Remove(Member);
        }
    }
}