﻿using Esourcing.Sourcing.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esourcing.Sourcing.Data
{
    public class SourcingContextSeed
    {
        //public static void SeedData(IMongoCollection<Auction> auctionCollection)
        //{
        //    bool exist = auctionCollection.Find(p => true).Any();
        //    if (!exist)
        //    {
        //        auctionCollection.InsertManyAsync(GetPreconfigureAuctions())
        //    }
        //}

        //private static IEnumerable<Auction> GetPreconfigureAuctions()
        //{
        //    return new List<Auction>()
        //    {
        //        new Auction()
        //        {
        //            Name = "Auction 1",
        //            Description ="Auction Desc 1",
        //            CreatedAt = DateTime.Now,
        //            StartedAt = DateTime.Now,
        //            FinishedAt = DateTime.Now,
        //            ProductId = "60093337093d7352d5467341",
        //            IncludedSellers = new List<string>()
        //            {
        //                "seller1@test.com",
        //                "seller2@test.com",
        //                "seller3@test.com"
        //            },
        //            Quantity = 5,
        //            Status =(int)Status.Active
        //        }
        //    }
        //}
    }
}
