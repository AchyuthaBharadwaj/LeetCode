def numUniqueEmails(emails: 'List[str]') -> 'int':
    list_of_addresses = []
    for email in emails:
        s = email.split('@')
        temp = s[0].split('+')[0]
        temp = temp.replace('.', '')
        mail_add = temp + s[1]
        if mail_add in list_of_addresses:
            continue
        else:
            list_of_addresses.append(mail_add)
    return len(list_of_addresses)

#Runtime: 44 ms, faster than 99.66% of Python3 online submissions for Unique Email Addresses.
print(numUniqueEmails(["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]))