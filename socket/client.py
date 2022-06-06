import socket
import sys

def sendMessage(message, currentUser):
    s = socket.socket(type=socket.SOCK_DGRAM)
    s.bind(('localhost', int(currentUser)))

    ADDRESS = ('localhost', 5000)
    MESSAGE = message.encode()

    totalSent = 0
    while (totalSent < len(MESSAGE)) :
        sent = s.sendto(MESSAGE[totalSent:], ADDRESS)
        totalSent += sent

    s.close()


if __name__ == '__main__':
    message = " ".join(sys.argv[2:])
    sendMessage(message, sys.argv[1])
