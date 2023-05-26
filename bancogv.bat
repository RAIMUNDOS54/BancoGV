docker build -t bancogv . && docker tag bancogv bancogv/bancogv && docker run -d -p 8086:8086 --name bancogv bancogv
