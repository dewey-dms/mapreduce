#!/bin/bash
dotnet publish
cd publish_example
rm *.dll
#cp ../gus_data/street_data.csv .
cp ../Dewey.MapReduce.Example.Mapper/bin/Debug/netcoreapp2.2/publish/*.dll .
cp ../Dewey.MapReduce.Example.Reducer/bin/Debug/netcoreapp2.2/publish/*.dll .
cp ../Dewey.MapReduce.Example.Combiner/bin/Debug/netcoreapp2.2/publish/*.dll .
cp ../Dewey.MapReduce.Example.Mapper.ReverseKeyAndValue/bin/Debug/netcoreapp2.2/publish/*.dll .
cd ..
tar -czvf publish_example.tar.gz  publish_example