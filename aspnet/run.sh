docker stop -t0 myapp
docker rm myapp
docker build -t aspnetapp .
docker run -d --network SQL -p 8080:80 --name myapp aspnetapp

