using System;

namespace EnumerationExercise1
{
    enum Days { ma, ti, ke, to, pe, la, su };

    enum Months { tammi, helmi, maalis, huhti, touko, kesä, heinä, elo, syys, loka, marras, joulu };

    enum Alphabet { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, x, y, z, å, ä, ö }

    enum ColoursWithOutFlags
    {
        sininen = 0x0,
        punainen = 0x1,
        keltainen = 0x2,
        vihreä = 0x4,
        oranssi = 0x8,
        pinkki = 0x10,
        musta = 0x20,
        valkoinen = 0x40
    }

    [Flags]
    enum ColoursWithFlags
    {
        sininen = 0x0,
        punainen = 0x1,
        keltainen = 0x2,
        vihreä = 0x4,
        oranssi = 0x8,
        pinkki = 0x10,
        musta = 0x20,
        valkoinen = 0x40
    }

}


