// Copie_scr_decoder.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>


unsigned int seed = 0x001be3ac;


unsigned int prng_rand()
{
    unsigned int r1, r3, r0;


    r0 = seed;
    r1 = (seed >> 1) | (seed << 31);
    r3 = ((r1 >> 16) & 0xFF) + r1;
    r1 = ((r3 >> 8) & 0xFF) << 16;
    r3 -= r1;
    seed = r3;


    return r0;
}


int main(int argc, char* argv[])
{
    FILE* fin, * fout;


    if (argc != 3)
    {
        printf("Usage: decode.exe [infile] [outfile]\n");
        exit(-1);
    }


    fin = fopen(argv[1], "rb");
    if (!fin)
    {
        printf("open %s failed\n", argv[1]);
        exit(-1);
    }


    fout = fopen(argv[2], "wb");
    if (!fout)
    {
        printf("create %s failed\n", argv[2]);
        exit(-1);
    }


    prng_rand();


    while (1)
    {
        int c = fgetc(fin);


        if (c == EOF)
            break;


        c ^= (prng_rand() & 0xFF);
        fputc(c, fout);
    }


    fclose(fin);
    fclose(fout);
}

