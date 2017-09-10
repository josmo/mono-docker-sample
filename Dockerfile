FROM mono:3.10
RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app
COPY ./mono-docker-sample.exe /usr/src/app
CMD [ "mono",  "./mono-docker-sample.exe" ]