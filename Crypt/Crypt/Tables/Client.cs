﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypt.Tables
{
    class Client
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndividualIdentificationNumber { get; set; }
        public string PositionName { get; set; }

        public override string ToString() =>
            $"{Id} | {FirstName} | {LastName} | {IndividualIdentificationNumber} | {PositionName}";

        public Client(string id, string firstName, string lastName,
            string individualIdentificationNumber, string positionName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IndividualIdentificationNumber = individualIdentificationNumber;
            PositionName = positionName;
        }
    }
}
