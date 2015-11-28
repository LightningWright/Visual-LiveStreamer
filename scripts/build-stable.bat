cd %git%\Visual-LiveStreamer
mkdir compile
cd stable\src
copy *.cpp %git%\Visual-LiveStreamer\compile
cd ..
cd headers
copy *.h %git%\Visual-LiveStreamer\compile
cd %git%\Visual-LiveStreamer\compile
g++ *.cpp -o app.exe
copy app.exe %git%\Visual-LiveStreamer\bin
cd %git%\Visual-LiveStreamer\bin
rd /s /q %git%\Visual-LiveStreamer\compile
start app.exe