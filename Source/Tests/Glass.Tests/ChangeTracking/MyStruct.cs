namespace Glass.Tests.ChangeTracking
{
    public struct MyStruct
    {
        public string Text { get; set; }
        public ChildStruct Child { get; set; }
    }

    public struct ChildStruct
    {
        public string Text { get; set; }
    }
}