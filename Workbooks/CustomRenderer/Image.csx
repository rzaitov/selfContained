class Image {
    public readonly int Width, Height;
    public Image (int width = 100, int height = 100)
    {
        this.Width = width;
        this.Height = height;
    }
}

RegisterResultHandler<Image> (img => {
    var w = 100;
    var h = 100;
    var componentNum = 4; // RGBA
    var bytesPerRow = w * componentNum;
    var bitsPerComponent = 8;
    var data = new byte [bytesPerRow * h];
    for (int x = 0; x < 100; x++) {
        for (int y = 0; y < 100; y++) {
            data [y * bytesPerRow + componentNum * x + 3] = 255;
        }
    }
    var provider = new CGDataProvider (data);
    var cgimg = new CGImage (w, h, bitsPerComponent, bitsPerComponent * componentNum, bytesPerRow, CGColorSpace.CreateDeviceRGB (), CGBitmapFlags.Last, provider, null, false, CGColorRenderingIntent.Default);
    return new NSImage (cgimg, new CGSize (w, h));
});