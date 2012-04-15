﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using VGA256;
//using Buffers;
//using Crt;

namespace MarioPort
{
   public static class Glitter
   {

          public const int MaxGlitter = 75;
          public const int W = 1; //temp
          public const int H = 1; //temp
          public const int MAX_PAGE = 20; //temp
          public const int VIR_SCREEN_WIDTH = 1; //temp


          public struct GlitterRec
          {
               public byte[] BackGr;
               public byte Attr;
               public uint Pos;
               public byte Dummy1, Dummy2, Dummy3;

               public GlitterRec(bool x)
               {
                  this.BackGr = new byte[MAX_PAGE];
                  this.Attr = 0;
                  this.Pos = 0;
                  this.Dummy1 = 0;
                  this.Dummy2 = 0;
                  this.Dummy3 = 0;
               }
          }

          public static string [] Count = new string[MaxGlitter];
          public static byte NumGlitter;
          public static GlitterRec[] GlitterList = new GlitterRec[MaxGlitter];

        public static void ClearGlitter()
        {
           for (int i = 0; i <= MaxGlitter; i++)
           {
              Count[i] = "0";
              //FillChar(Count, SizeOf(Count), 0);
           }
        }

        public static void NewGlitter(int X, int Y, byte NewAttr, byte Duration)
        {
              //int i;
           //if (X < Buffers.XView || X >= Buffers.XView + NH * W)
              //   return;
              //i = 1;
              //while (Count[i] > (byte)0 && i < MaxGlitter)
              //{
              //   i++;
              //   if (i < MaxGlitter)
              //   {
           //      if (Y < 0 || Y > Buffers.NV * H)
              //         return;
              //      //Count[i] = Chr(Duration);
              //      NumGlitter++;
              //      GlitterList[i].Pos = (uint)(Y * VIR_SCREEN_WIDTH + X);
              //      //FillChar(BackGr, SizeOf (BackGr), #0);
              //      GlitterList[i].Attr = NewAttr;
              //   }
              //}
        }


        public static void NewStar(int X, int Y, byte NewAttr, byte Duration)
         {
            NewGlitter(X, Y, NewAttr, (byte)(Duration + 4));
            NewGlitter(X + 1, Y, NewAttr, Duration);
            NewGlitter(X, Y + 1, NewAttr, Duration);
            NewGlitter(X - 1, Y, NewAttr, Duration);
            NewGlitter(X, Y - 1, NewAttr, Duration);
        }

         public static void ShowGlitter()
         {
            //var
            //  int i, Page; //: Integer;
            //  uint PageOffset; //: Word;
            //begin
            //  PageOffset = GetPageOffset;
            //  Page = CurrentPage;
            //  if NumGlitter > 0 then
            //    for i := 1 to MaxGlitter do
            //      if Count [i] > Chr (MAX_PAGE + 1) then
            //        {
            //          with GlitterList [i] do
            //          begin
            //            BackGr[WorkingPage] = FormMarioPort.formRef.GetPixel(XPos, YPos);
            //            PutPixel(XPos, YPos, Attr);
            //          end
            //        }
            //        asm
            //                push    es
            //                push    ds
            //                mov     ax, seg @Data
            //                mov     ds, ax
            //                mov     si, offset GlitterList
            //                mov     ax, VGA_SEGMENT
            //                mov     es, ax
            //                mov     bx, i
            //                dec     bx
            //                mov     cl, 3
            //                shl     bx, cl
            //                add     si, bx
            //                lodsb                   { Attr }
            //                push    ax
            //                lodsw                   { Pos }

            //                mov     di, ax
            //                shr     di, 1
            //                shr     di, 1
            //                add     di, PageOffset
            //                and     al, 3
            //                mov     cl, al

            //                mov     dx, GC_INDEX
            //                mov     ah, al
            //                mov     al, READ_MAP
            //                out     dx, ax

            //                seges
            //                mov     bl, [di]

            //                mov     ah, 1
            //                shl     ah, cl
            //                mov     dx, SC_INDEX
            //                mov     al, MAP_MASK
            //                out     dx, ax

            //                pop     ax
            //                stosb

            //                add     si, Page
            //                mov     [si], bl        { BackGr [Page] }
            //                pop     ds
            //                pop     es
            //        end
            //      else
            //        if Count [i] > #0 then
            //          with GlitterList [i] do
            //            BackGr [CurrentPage] := 0;
            //end;
        }

        public static void HideGlitter()
        {
              //var
              //  i,
              //  Page: Integer;
              //  PageOffset: Word;
              //begin
              //  PageOffset = GetPageOffset;
              //  if NumGlitter = 0 then
              //    Exit;
              //  Page = CurrentPage;
              //  for i = MaxGlitter downto 1 do
              //    if Count [i] > #0 then
              //    begin
              //      {
              //      with GlitterList [i] do
              //        if BackGr [WorkingPage] <> 0 then
              //          PutPixel(XPos, YPos, BackGr [WorkingPage]);
              //      }
              //          asm
              //                push    es
              //                push    ds
              //                mov     ax, seg @Data
              //                mov     ds, ax
              //                mov     si, offset GlitterList
              //                mov     ax, VGA_SEGMENT
              //                mov     es, ax
              //                mov     bx, i
              //                dec     bx
              //                mov     cl, 3
              //                shl     bx, cl
              //                add     si, bx
              //                lodsb                   { Attr }
              //                lodsw                   { Pos }
              //                mov     di, ax
              //                mov     cx, ax
              //                add     si, Page
              //                mov     bl, [si]        { BackGr [Page] }
              //                or      bl, bl
              //                jz      @1
              //                shr     di, 1
              //                shr     di, 1
              //                add     di, PageOffset
              //                mov     ah, 1
              //                and     cl, 3
              //                shl     ah, cl
              //                mov     dx, SC_INDEX
              //                mov     al, MAP_MASK
              //                out     dx, ax
              //                mov     al, bl
              //                stosb
              //          @1:   pop     ds
              //                pop     es
              //          end;
              //      Dec (Count [i]);
              //      if Count [i] = #0 then
              //        Dec (NumGlitter);
              //    end;
              //end;
        }

        public static void CoinGlitter(int X, int Y)
        {
           NewStar(X + 5, Y + 2, (byte)1F, (byte)20);
           NewStar(X + W - 6, Y + 6, (byte)1F, (byte)18);
           NewStar(X + 10, Y + H - 3, (byte)1F, (byte)16);
           NewGlitter(X + W - 9, Y + 2, (byte)1F, (byte)15);
           NewGlitter(X + 6, Y + 7, (byte)1F, (byte)17);
           NewGlitter(X + 3, Y + 9, (byte)1F, (byte)15);
        }

        public static void StartGlitter(int X, int Y, int W, int H)
        {
           int i;
           Random num = new Random();
           int first = num.Next(10);
           int w = num.Next(W);
           int h = num.Next(H);
           NewStar(X + w, Y + h, (byte)1F, (byte)(10 + first));
           for( i = 1; i <= 4; i++ )
           {
              NewGlitter (X + w, Y + h, (byte)1F, (byte)(5 + first));
           }
        }
   }
}
