<script>
    import Input from "./Input.svelte";
</script>

<style>
    th {
        font-weight: 500;
        text-align: left;
    }

    tr td,
    tr th {
        padding: 0.2rem 0;
        vertical-align: top;
    }

    tr:not(:hover):not(:focus-within) :global(.auto-expanding),
    tr:not(:hover):not(:focus-within) :global(select),
    tr:not(:hover):not(:focus-within) :global(input) {
        border-color: #eee;
    }

    table {
        margin-top: 2rem;
        table-layout: fixed;
        width: 100%;
    }

    td:first-child {
        padding-right: 0.5rem;
    }

    .feature {
        width: 40%;
    }
</style>

<div class="features">
    <table cellspacing="0" cellpadding="0">
        <colgroup>
            <col class="feature" />
            <col class="allowlist" />
        </colgroup>
        <thead>
            <tr>
                <th>Feature</th>
                <th>Allowlist</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <Input>
                        <option value="accelerometer">accelerometer</option>
                        <option value="fullscreen">fullscreen</option>
                    </Input>
                </td>
                <td>
                    <Input placeholder="None allowed" autoexpand />
                </td>
            </tr>
            <tr>
                <td>
                    <Input>
                        <option value="accelerometer">accelerometer</option>
                        <option value="fullscreen">fullscreen</option>
                    </Input>
                </td>
                <td>
                    <Input placeholder="None allowed" />
                </td>
            </tr>
            <tr>
                <td>
                    <Input>
                        <option value="accelerometer">accelerometer</option>
                        <option value="fullscreen">fullscreen</option>
                    </Input>
                </td>
                <td>
                    <Input placeholder="None allowed" />
                </td>
            </tr>
        </tbody>
    </table>
</div>
