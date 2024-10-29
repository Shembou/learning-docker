FROM node:latest as build-env
WORKDIR /app
COPY ["package.json","package-lock.json","/app/"]
RUN npm install
RUN npm install -g @angular/cli

ARG API_ENDPOINT=http://localhost:8080/api
ENV API_ENDPOINT=${API_ENDPOINT}


COPY . /app

RUN ng build
CMD ng serve --host 0.0.0.0 --port 4000