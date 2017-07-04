namespace Store
{
    public abstract class BaseProduct
    {
        private string vTitle;
        public string Title
        {
            get { return vTitle; }
            set { vTitle = value; }
        }
        public int ProductId { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public abstract bool IsValid();

        //  public bool Equals(BaseProduct other)
        // {
        //    if (other == null) return false;
        //   if (ReferenceEquals(this, other)) return true;
        //    return this.ProductCategory == other.ProductCategory && this.vProductName == other.vProductName;
        //throw new NotImplementedException();
        //  }
        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;
        //    if (obj.GetType() != this.GetType())
        //        return false;
        //    if (ReferenceEquals(obj, this))
        //        return true;
        //    // BaseProduct rhs =  obj as BaseProduct;
        //    BaseProduct rhs = (BaseProduct)obj ;
        //    return this.ProductCategory == rhs.ProductCategory && this.vProductName == rhs.vProductName;
        //}
        //public static bool operator ==(BaseProduct x, BaseProduct y)
        //{
        //    return object.Equals(x,y);
        //}
        //public static bool operator !=(BaseProduct x, BaseProduct y)
        //{
        //    return !object.Equals(x, y);
        //}
        //public override int GetHashCode()
        //{
        //    return vProductName.GetHashCode() ^ ProductCategory.GetHashCode();
        //}

    }
}
