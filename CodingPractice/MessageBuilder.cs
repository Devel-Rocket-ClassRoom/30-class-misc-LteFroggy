using System.Text;

class MessageBuilder {
    StringBuilder sb;

    public MessageBuilder() {
        sb = new StringBuilder();
    }

    public MessageBuilder AddText(string text) {
        sb.Append(text);
        return this;
    }

    public MessageBuilder AddSpace() {
        sb.Append(" ");
        return this;
    }

    public MessageBuilder AddNewLine() {
        sb.Append("\n");
        return this;
    }

    public string Build() {
        return sb.ToString();
    }
}