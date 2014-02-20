from wsgiref import simple_server

class PimpedWSGIServer(simple_server.WSGIServer):
    # To increase the backlog
    request_queue_size = 500
 
class PimpedHandler(simple_server.WSGIRequestHandler):
    # to disable logging
    def log_message(self, *args):
        pass


def application(environ, start_response):
    body = 'Hello, world'
    start_response('200 OK', [('Content-type', 'text/plain'),('Content-Length', str(len(body)))])
    return (body)



if __name__ == '__main__':
    server = PimpedWSGIServer(('', 12345), PimpedHandler)
    server.set_app(application)
    server.serve_forever()