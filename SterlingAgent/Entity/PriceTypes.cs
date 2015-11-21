using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIAgent.Entity
{
    public enum PriceTypes
    {
        ptSTIUnknown = 0,
        ptSTIMkt = 1,
        ptSTIMktClo = 2,
        ptSTIMktOb = 3,
        ptSTIMktWow = 4,
        ptSTILmt = 5,
        ptSTILmtClo = 6,
        ptSTILmtStp = 7,
        ptSTILmtStpLmt = 8,
        ptSTILmtOb = 9,
        ptSTIWow = 10,
        ptSTILmtWow = 11,
        ptSTIBas = 12,
        ptSTIClo = 13,
        ptSTIPegged = 14,
        ptSTIFunari = 28,
        ptSTISvrStp = 100,
        ptSTISvrStpLmt = 101,
        ptSTITrailStp = 102,
        ptSTILast = 103,
    }
}
