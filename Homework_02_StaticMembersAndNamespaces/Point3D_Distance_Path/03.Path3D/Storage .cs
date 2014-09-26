namespace Point3dDistancePath._03.Path3D
{
    using System;
    using System.IO;
    using Point3dDistancePath._01._3DPoint;

    public static class Storage
    {
        public static void LoadPathFromFile(string filePath, Path3D path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        Point3D point = new Point3D();
                        string[] coordinates = line.Split(new char[] { '(', ',', ')', ' ' },
                                                   StringSplitOptions.RemoveEmptyEntries);
                        point.X = int.Parse(coordinates[0]);
                        point.Y = int.Parse(coordinates[1]);
                        point.Z = int.Parse(coordinates[2]);

                        path.pointSequence.Add(point);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine(
                "Can not find file {0}.", filePath);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine(
                "Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine(
                "Can not open the file {0}", filePath);
            }
        }

        public static void SafePathToFile(string filePath, Path3D path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 0; i < path.pointSequence.Count; i++)
                    {
                        writer.WriteLine(path.pointSequence[i]);
                    }
                }
            }
            catch (IOException exc)
            {
                Console.WriteLine("Error: {0}.", exc.Message);
            }
        }
    }
}
