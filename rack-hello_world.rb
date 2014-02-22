require 'rubygems'
require 'rack'

class HelloWorld
  def call(env)
    env["app.logger"] = Rack::NullLogger
    return [200, {}, ["Hello world!"]]
  end
end

Rack::Handler::WEBrick.run HelloWorld.new, :Port => 12345
