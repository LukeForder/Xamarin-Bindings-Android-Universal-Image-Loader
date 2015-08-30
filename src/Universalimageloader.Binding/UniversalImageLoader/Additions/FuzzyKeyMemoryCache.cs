namespace Com.Nostra13.Universalimageloader.Cache.Memory.Impl
{
    public partial class FuzzyKeyMemoryCache
    {
        public global::Java.Lang.Object Get(global::Java.Lang.Object p0)
        {
            return Get((string)p0);
        }

        public void Remove(global::Java.Lang.Object p0)
        {
            Remove((string)p0);
        }

        public bool Put(global::Java.Lang.Object p0, global::Java.Lang.Object p1)
        {
            return Put((string)p0, (global::Android.Graphics.Bitmap)p1);
        }
    }
}

