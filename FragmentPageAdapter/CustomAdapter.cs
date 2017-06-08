using System;
using Android.Runtime;
using Android.Support.V4.App;

namespace FragmentPageAdapter
{
    public class CustomAdapter: FragmentPagerAdapter
    {
        public CustomAdapter(FragmentManager fm) : base(fm)
        {

        }

        public override int Count => 6;

        public override Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0:
                    return new Fragment1();
                case 1:
                    return new Fragment2();
                case 2:
                    return new Fragment3();
                case 3:
                    return new Fragment4();
                case 4:
                    return new Fragment5();
                case 5:
                    return new Fragment6();

                default:
                    return new Fragment1();
            }
        }
    }
}