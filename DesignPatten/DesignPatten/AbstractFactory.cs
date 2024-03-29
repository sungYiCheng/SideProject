﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatten
{
    internal partial class DesignPatten
    {
        /*
         * 
         * 使用時機: 
         * 
         * 抽象工廠的重點在於，能夠幫助我們快速建立一系列的產品，譬如棒球衣和棒球鞋、網球衣和網球鞋(重點是混和不同系列)。
         * 雖然這這些產品之前可能沒有關係（衣服和鞋子），不過我們可以透過抽象工廠，將它們組合在一起
         * 
         * 
         * 優點:
         * 
         * 能夠讓使用者只要透過一個工廠，就能夠得到系列產品
         * 當我們定義好系列產品的樣子之後，就可以擴張成不同系列，譬如從原本的棒球系列，拓展的籃球系列、足球系列
         * 
         * 
         * 壞處
         * 
         * 如果我們要拓展系列本身，譬如從原本的「衣服 + 鞋子」，變成「衣服 + 鞋子 + 帽子」，那麼就會牽一髮動全身，所有不同系列（棒球、網球、籃球 ... 等）的實作工廠都要同時變動。
         * 
         * 
         * 
         * 使用場景
如果系列本身只有一個產品，譬如我只做衣服產品（棒球衣、網球衣、足球衣），那麼其實就跟原本的工廠模式一樣，就不需要使用到抽象工廠模式。

另一方面，如果只有一種系列要做，譬如我只想做棒球系列（棒球衣、棒球鞋、棒球帽），那麼甚至我們可以直接使用簡單工廠，讓使用者傳入參數（訂單），然後直接產出他們需要的產品即可。不需要考慮到任何擴張的情境。


         * 
         * 
         * 
         */


        public class AbstractFactory 
        {
            
        }
    }
}
