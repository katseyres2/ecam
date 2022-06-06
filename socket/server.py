import socket
import threading
import time
import logging


class Server():
    def __init__(self, host='localhost', port=5000):
        logging.basicConfig(filename='historic.log', encoding='utf-8', level=logging.DEBUG)
        s = socket.socket(type=socket.SOCK_DGRAM)
        s.bind((host, port))
        self.__s = s
    
    def run(self):
        self.__running = True
        self.__address = None

        while self.__running:
            data = self.__s.recvfrom(512)
            display = f"[{time.ctime()}] {data[1][0]}:{data[1][1]} -> {data[0].decode()}"
            print(display)
            logging.info(display)


if __name__ == '__main__':
    s = Server()
    s.run()
